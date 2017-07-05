using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    public class ExtendedVMBuildEventCode: GalaSoft.MvvmLight.ViewModelBase
    {
        public const string EntityName_Static = "MSBuildExtensionPack.BuildEventCode";

        public string EntityName { get { return EntityName_Static; } }

        public ExtendedVMBuildEventCode()
			: base()
        {

        }



        public override void Cleanup()
        {
        }
    }
}

