using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Messaging;

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    public class ExtendedVMSolution: GalaSoft.MvvmLight.ViewModelBase
    {
        #region constructor

        public ExtendedVMSolution()
			: base()
        {


            #region Commands for LinkedButton in List



            #endregion Commands for LinkedButton in List
        }

        #endregion constructor



        #region LinkButton Command to Details of referenced entities



        #endregion LinkButton Command to Details of referenced entities

        public override void Cleanup()
        {
        }
    }
}
