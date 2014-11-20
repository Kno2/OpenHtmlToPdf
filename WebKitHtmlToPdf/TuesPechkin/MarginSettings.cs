﻿using System;

namespace WebKitHtmlToPdf.TuesPechkin
{
    [Serializable]
    class MarginSettings
    {
        public MarginSettings()
        {
            this.Unit = Unit.Inches;
        }

        public MarginSettings(double top, double right, double bottom, double left) : this()
        {
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
            this.Left = left;
        }

        public double Bottom { get; set; }

        public double Left { get; set; }

        public double Right { get; set; }

        public double Top { get; set; }

        public double All
        {
            set
            {
                this.Top = this.Right = this.Bottom = this.Left = value;
            }
        }

        /// <summary>
        /// Defaults to Inches.
        /// </summary>
        public Unit Unit { get; set; }
    }
}