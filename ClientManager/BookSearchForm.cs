﻿using LibraryManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManager
{
    public partial class BookSearchForm : Form
    {
        public BookSearchForm()
        {
            InitializeComponent();
            checkedListBoxSearchGenre.DataSource = Enum.GetNames(typeof(BookGenre));
        }
    }
}
