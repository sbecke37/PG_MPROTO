using PG_MPROTO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PG_MPROTO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotePage : ContentPage
    {
        NoteViewModel vm;
        public NotePage()
        {
            InitializeComponent();
            //BindingContext = vm = new NoteViewModel();
           //dataForm.DataObject = new NoteViewModel();
        }
    }
}