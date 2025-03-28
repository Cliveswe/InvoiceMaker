﻿using System;

namespace InvoiceMaker.ViewModel.ButtonControls
{
    class LoadInvoiceFileNameEventArgs:EventArgs
    {
        /// <summary>
        /// Invoice file name.
        /// </summary>
        public readonly string invoiceFileName;
        /// <summary>
        /// Invoice file name.
        /// </summary>
        /// <param name="msg"></param>
        public LoadInvoiceFileNameEventArgs(string msg)
        {
            invoiceFileName = msg;
        }
        /// <summary>
        /// Current invoice name is empty.
        /// </summary>
        public LoadInvoiceFileNameEventArgs()
        {
            invoiceFileName = string.Empty;
        }
    }
}
