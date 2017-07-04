using System;
using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using Xamarin.Forms;

namespace Framework.Xamariner
{
    // License Url: https://github.com/Oceanware/XamarinFormsBindablePicker/blob/master/LICENSE
    /*
    MIT License

    Copyright (c) 2016 Karl Shifflett

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
    */
    /// <summary>
    /// https://github.com/Oceanware/XamarinFormsBindablePicker/blob/master/XamarinFormsBindablePicker/XamarinFormsBindablePicker/Controls/BindablePicker.cs
    /// </summary>
    /// <seealso cref="Xamarin.Forms.Picker" />
    public class BindablePicker : Picker
    {

        Boolean _disableNestedCalls;

        public new static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create("ItemsSource", typeof(IEnumerable), typeof(BindablePicker),
                null, propertyChanged: OnItemsSourceChanged);

        public new static readonly BindableProperty SelectedItemProperty =
            BindableProperty.Create("SelectedItem", typeof(Object), typeof(BindablePicker),
                null, BindingMode.TwoWay, propertyChanged: OnSelectedItemChanged);

        public static readonly BindableProperty SelectedValueProperty =
            BindableProperty.Create("SelectedValue", typeof(Object), typeof(BindablePicker),
                null, BindingMode.TwoWay, propertyChanged: OnSelectedValueChanged);

        public String DisplayMemberPath { get; set; }

        public new IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public new Object SelectedItem
        {
            get { return GetValue(SelectedItemProperty); }
            set
            {
                if (this.SelectedItem != value)
                {
                    SetValue(SelectedItemProperty, value);
                    InternalSelectedItemChanged();
                }
            }
        }

        public Object SelectedValue
        {
            get { return GetValue(SelectedValueProperty); }
            set
            {
                SetValue(SelectedValueProperty, value);
                InternalSelectedValueChanged();
            }
        }

        public String SelectedValuePath { get; set; }

        public BindablePicker()
        {
            this.SelectedIndexChanged += OnSelectedIndexChanged;
        }

        public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

        void InstanceOnItemsSourceChanged(Object oldValue, Object newValue)
        {
            _disableNestedCalls = true;
            this.Items.Clear();

            var oldCollectionINotifyCollectionChanged = oldValue as INotifyCollectionChanged;
            if (oldCollectionINotifyCollectionChanged != null)
            {
                oldCollectionINotifyCollectionChanged.CollectionChanged -= ItemsSource_CollectionChanged;
            }

            var newCollectionINotifyCollectionChanged = newValue as INotifyCollectionChanged;
            if (newCollectionINotifyCollectionChanged != null)
            {
                newCollectionINotifyCollectionChanged.CollectionChanged += ItemsSource_CollectionChanged;
            }

            if (!Equals(newValue, null))
            {
                var hasDisplayMemberPath = !String.IsNullOrWhiteSpace(this.DisplayMemberPath);

                foreach (var item in (IEnumerable)newValue)
                {
                    if (hasDisplayMemberPath)
                    {
                        var type = item.GetType();
                        var prop = type.GetRuntimeProperty(this.DisplayMemberPath);
                        this.Items.Add(prop.GetValue(item).ToString());
                    }
                    else
                    {
                        this.Items.Add(item.ToString());
                    }
                }

                this.SelectedIndex = -1;
                this._disableNestedCalls = false;

                if (this.SelectedItem != null)
                {
                    this.InternalSelectedItemChanged();
                }
                else if (hasDisplayMemberPath && this.SelectedValue != null)
                {
                    this.InternalSelectedValueChanged();
                }
            }
            else
            {
                _disableNestedCalls = true;
                this.SelectedIndex = -1;
                this.SelectedItem = null;
                this.SelectedValue = null;
                _disableNestedCalls = false;
            }
        }

        void InternalSelectedItemChanged()
        {
            if (_disableNestedCalls)
            {
                return;
            }

            var selectedIndex = -1;
            Object selectedValue = null;
            if (this.ItemsSource != null)
            {
                var index = 0;
                var hasSelectedValuePath = !String.IsNullOrWhiteSpace(this.SelectedValuePath);
                foreach (var item in this.ItemsSource)
                {
                    if (item != null && item.Equals(this.SelectedItem))
                    {
                        selectedIndex = index;
                        if (hasSelectedValuePath)
                        {
                            var type = item.GetType();
                            var prop = type.GetRuntimeProperty(this.SelectedValuePath);
                            selectedValue = prop.GetValue(item);
                        }
                        break;
                    }
                    index++;
                }
            }
            _disableNestedCalls = true;
            this.SelectedValue = selectedValue;
            this.SelectedIndex = selectedIndex;
            _disableNestedCalls = false;
        }

        void InternalSelectedValueChanged()
        {
            if (_disableNestedCalls)
            {
                return;
            }

            if (String.IsNullOrWhiteSpace(this.SelectedValuePath))
            {
                return;
            }
            var selectedIndex = -1;
            Object selectedItem = null;
            var hasSelectedValuePath = !String.IsNullOrWhiteSpace(this.SelectedValuePath);
            if (this.ItemsSource != null && hasSelectedValuePath)
            {
                var index = 0;
                foreach (var item in this.ItemsSource)
                {
                    if (item != null)
                    {
                        var type = item.GetType();
                        var prop = type.GetRuntimeProperty(this.SelectedValuePath);
                        if (Object.Equals(prop.GetValue(item), this.SelectedValue))
                        {
                            selectedIndex = index;
                            selectedItem = item;
                            break;
                        }
                    }

                    index++;
                }
            }
            _disableNestedCalls = true;
            this.SelectedItem = selectedItem;
            this.SelectedIndex = selectedIndex;
            _disableNestedCalls = false;
        }

        void ItemsSource_CollectionChanged(Object sender, NotifyCollectionChangedEventArgs e)
        {
            var hasDisplayMemberPath = !String.IsNullOrWhiteSpace(this.DisplayMemberPath);
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    if (hasDisplayMemberPath)
                    {
                        var type = item.GetType();
                        var prop = type.GetRuntimeProperty(this.DisplayMemberPath);
                        this.Items.Add(prop.GetValue(item).ToString());
                    }
                    else
                    {
                        this.Items.Add(item.ToString());
                    }
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (var item in e.NewItems)
                {
                    if (hasDisplayMemberPath)
                    {
                        var type = item.GetType();
                        var prop = type.GetRuntimeProperty(this.DisplayMemberPath);
                        this.Items.Remove(prop.GetValue(item).ToString());
                    }
                    else
                    {
                        this.Items.Remove(item.ToString());
                    }
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                foreach (var item in e.NewItems)
                {
                    if (hasDisplayMemberPath)
                    {
                        var type = item.GetType();
                        var prop = type.GetRuntimeProperty(this.DisplayMemberPath);
                        this.Items.Remove(prop.GetValue(item).ToString());
                    }
                    else
                    {
                        var index = this.Items.IndexOf(item.ToString());
                        if (index > -1)
                        {
                            this.Items[index] = item.ToString();
                        }
                    }
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Reset)
            {
                this.Items.Clear();
                if (e.NewItems != null)
                {
                    foreach (var item in e.NewItems)
                    {
                        if (hasDisplayMemberPath)
                        {
                            var type = item.GetType();
                            var prop = type.GetRuntimeProperty(this.DisplayMemberPath);
                            this.Items.Remove(prop.GetValue(item).ToString());
                        }
                        else
                        {
                            var index = this.Items.IndexOf(item.ToString());
                            if (index > -1)
                            {
                                this.Items[index] = item.ToString();
                            }
                        }
                    }
                }
                else
                {
                    _disableNestedCalls = true;
                    this.SelectedItem = null;
                    this.SelectedIndex = -1;
                    this.SelectedValue = null;
                    _disableNestedCalls = false;
                }
            }
        }

        static void OnItemsSourceChanged(BindableObject bindable, Object oldValue, Object newValue)
        {
            if (Equals(newValue, null) && Equals(oldValue, null))
            {
                return;
            }

            var picker = (BindablePicker)bindable;
            picker.InstanceOnItemsSourceChanged(oldValue, newValue);
        }

        void OnSelectedIndexChanged(Object sender, EventArgs e)
        {
            if (_disableNestedCalls)
            {
                return;
            }

            if (this.SelectedIndex < 0 || this.ItemsSource == null || !this.ItemsSource.GetEnumerator().MoveNext())
            {
                _disableNestedCalls = true;
                if (this.SelectedIndex != -1)
                {
                    this.SelectedIndex = -1;
                }
                this.SelectedItem = null;
                this.SelectedValue = null;
                _disableNestedCalls = false;
                return;
            }

            _disableNestedCalls = true;

            var index = 0;
            var hasSelectedValuePath = !String.IsNullOrWhiteSpace(this.SelectedValuePath);
            foreach (var item in this.ItemsSource)
            {
                if (index == this.SelectedIndex)
                {
                    this.SelectedItem = item;
                    if (hasSelectedValuePath)
                    {
                        var type = item.GetType();
                        var prop = type.GetRuntimeProperty(this.SelectedValuePath);
                        this.SelectedValue = prop.GetValue(item);
                    }

                    break;
                }
                index++;
            }

            _disableNestedCalls = false;
        }

        static void OnSelectedItemChanged(BindableObject bindable, Object oldValue, Object newValue)
        {
            var boundPicker = (BindablePicker)bindable;
            boundPicker.ItemSelected?.Invoke(boundPicker, new SelectedItemChangedEventArgs(newValue));
            boundPicker.InternalSelectedItemChanged();
        }

        static void OnSelectedValueChanged(BindableObject bindable, Object oldValue, Object newValue)
        {
            var boundPicker = (BindablePicker)bindable;
            boundPicker.InternalSelectedValueChanged();
        }

    }
}

