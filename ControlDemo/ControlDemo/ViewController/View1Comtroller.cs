using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Globalization;

namespace ControlDemo.ViewController
{
    class View1Comtroller : INotifyPropertyChanged
    {
        private Color ttmailcolor    = Color.Teal;
        private Color bgworkcolor    = Color.Teal;
        private Color calendercolor  = Color.Teal;
        private Color blogcolor      = Color.Teal;
        private Color contactcolor   = Color.Teal;

        private Color ttmailtextcolor    = Color.White;
        private Color textworkcolor       = Color.White;
        private Color calendertextcolor  = Color.White;
        private Color blogtextcolor      = Color.White;
        private Color contacttextcolor   = Color.White;
        private bool  isvisible = false;
        public  int count = 0;

        private bool istttmailvisibility   = false;
        private bool iscalendervisibility  = false;
        private bool isworkspacevisibility = false;
        private bool Isblogvisibility      = false;
        private bool iscontactvisibility   = false;

        public bool IsTTMailVisibility { get { return istttmailvisibility; } set { istttmailvisibility   = value; } }
        public bool IsContactVisibility  { get { return iscontactvisibility;  }set { iscontactvisibility   = value;}}
        public bool IsBlogVisibility     { get { return Isblogvisibility;     }set { Isblogvisibility      = value;}}
        public bool IsWorkspaceVisibility{ get { return isworkspacevisibility;}set { isworkspacevisibility = value;}}
        public bool IsCalenderVisibility { get { return iscalendervisibility; }set { iscalendervisibility  = value;}}

        public bool  IsVisible       { get { return isvisible;       } set { isvisible = value; }}
        public Color BgWorkColor     { get { return bgworkcolor;    } set { bgworkcolor= value;}}
        public Color TTMailColor     { get { return ttmailcolor;    } set { ttmailcolor = value;}}
        public Color CalenderColor   { get { return calendercolor;  } set { calendercolor = value;}}
        public Color BlogColor       { get { return blogcolor;      } set { blogcolor = value; } }
        public Color ContactColor    { get { return contactcolor;   } set { contactcolor = value; } }

        public Color TextWorkColor      { get { return textworkcolor; }     set { textworkcolor = value; } }
        public Color TTMailTextColor    { get { return ttmailtextcolor; }   set { ttmailtextcolor = value; } }
        public Color CalenderTextColor  { get { return calendertextcolor; } set { calendertextcolor = value; } }
        public Color BlogTextColor      { get { return blogtextcolor; }     set { blogtextcolor = value; } }
        public Color ContactTextColor   { get { return contacttextcolor; }  set { contacttextcolor = value; } }

        public View1Comtroller()
        {
            MenuClick  = new Command(IsVisibleMenu);
            TTMail     = new Command(TTMail_Click);
            Calender   = new Command(Calender_Click);
            WorkSpace  = new Command(WorkSpace_Click);
            Blog       = new Command(Blog_Click);
            Contact    = new Command(Contact_Click);
        }

        public ICommand MenuClick { get; set; }
        public ICommand TTMail    { get; set;}
        public ICommand Calender  { get; set; }
        public ICommand WorkSpace { get; set; }
        public ICommand Blog      { get; set; }
        public ICommand Contact   { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void ClearColor()
        {
            ttmailcolor        = Color.Teal;
            ttmailtextcolor    = Color.White;
            calendercolor      = Color.Teal;
            calendertextcolor  = Color.White;
            bgworkcolor        = Color.Teal;
            textworkcolor      = Color.White;
            blogcolor          = Color.Teal;
            blogtextcolor      = Color.White;
            contactcolor       = Color.Teal;
            contacttextcolor   = Color.White;

            istttmailvisibility   = false;
            iscalendervisibility  = false;
            isworkspacevisibility = false;
            Isblogvisibility      = false;
            iscontactvisibility   = false;
    }

        public void ToggleColor(int C)
        {
            if (C == 1)      { ttmailcolor   = Color.White; ttmailtextcolor = Color.Gray;   istttmailvisibility   = true; }
            else if( C == 2)
            { calendercolor = Color.White;
                calendertextcolor = Color.Gray;
                iscalendervisibility  = true;
            }
            else if (C == 3) { bgworkcolor   = Color.White; textworkcolor = Color.Gray;     isworkspacevisibility = true; }
            else if (C == 4) { blogcolor     = Color.White; blogtextcolor = Color.Gray;     Isblogvisibility      = true; }
            else if (C == 5) { contactcolor  = Color.White; contacttextcolor = Color.Gray;  iscontactvisibility   = true; }
            OnClickChangeColor();
        }

        public void OnClickChangeColor()
        {
            OnPropertyChanged("TTMailColor"); OnPropertyChanged("TTMailTextColor");
            OnPropertyChanged("CalenderColor"); OnPropertyChanged("CalenderTextColor");
            OnPropertyChanged("BgWorkColor"); OnPropertyChanged("TextWorkColor");
            OnPropertyChanged("BlogColor"); OnPropertyChanged("BlogTextColor");
            OnPropertyChanged("ContactColor"); OnPropertyChanged("ContactTextColor");
            // Change Visibility of User Control View in Main Page 
            OnPropertyChanged("IsTTMailVisibility"); OnPropertyChanged("IsContactVisibility"); OnPropertyChanged("IsBlogVisibility"); OnPropertyChanged("IsWorkspaceVisibility"); OnPropertyChanged("IsCalenderVisibility");
        }

        public void TTMail_Click()    {ClearColor(); ToggleColor(1);}
        public void Calender_Click()  {ClearColor(); ToggleColor(2);}
        public void WorkSpace_Click() {ClearColor(); ToggleColor(3);}
        public void Blog_Click()      {ClearColor();ToggleColor(4);}
        public void Contact_Click()   {ClearColor();  ToggleColor(5);}
    
        private  void IsVisibleMenu()
        {
            if(count == 0)
            {
                isvisible = true; OnPropertyChanged("IsVisible"); count = 1;
            }
            else if (count == 1)
            {
                isvisible = false; OnPropertyChanged("IsVisible");count = 0;
            }

        }


    }
    

}
