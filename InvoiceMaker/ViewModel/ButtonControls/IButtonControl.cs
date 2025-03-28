﻿using System;
using System.ComponentModel;

namespace InvoiceMaker.ButtonControls
{
    interface IButtonControl : INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// Gets or sets the content of the button.
        /// </summary>
        /// <value>
        /// The content of the button.
        /// </value>
        string ButtonContent
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is enabled; otherwise, <c>false</c>.
        /// </value>
        bool IsEnabled
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the button command.
        /// </summary>
        /// <value>
        /// The button command.
        /// </value>
        RelayCommands ButtonCommand
        {
            get;
            set;
        }
        /// <summary>
        /// Button is pressed execute method.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        void ButtonExecute(Object parameter);
        /// <summary>
        /// Can the button be executed.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        bool ButtonCanExecute(Object parameter);
    }
}
