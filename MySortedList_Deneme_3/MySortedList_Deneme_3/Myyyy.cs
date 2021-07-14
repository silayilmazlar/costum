using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace MySortedList_Deneme_3
{
   
        class MySortedList : ListView
        {
        /// <summary>
        /// kendi sorted listimizi oluşturmak için yaptığımız custom control kodu
        /// ListView'dan kalıtım yapılarak form içinde oluşturma.
        /// Oluşturulan control'ün boyut ayarları ("this.Size=...")
        /// </summary> 
        private bool isSorted = true;

            [Description("switch with Control")]
            [Category("My Sorted")]
            [DefaultValue(true)]
            public bool IsSorted
            {
                get { return isSorted; }
                set { isSorted = value; }
            }
            protected override void OnMouseEnter(EventArgs e)
            {

                this.Size = new System.Drawing.Size(310,250);
                base.OnMouseEnter(e);
            }
        
        
        }
}
