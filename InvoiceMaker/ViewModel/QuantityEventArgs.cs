﻿namespace InvoiceMaker.ViewModel
{
    class QuantityEventArgs
    {
        /// <summary>
        /// The new quantity value.
        /// </summary>
        public readonly string value;
        /// <summary>
        /// A new quantity has been inputed via the UI.
        /// </summary>
        /// <param name="value">A string</param>
        public QuantityEventArgs(string value)
        {
            this.value = value;
        }
    }
}
