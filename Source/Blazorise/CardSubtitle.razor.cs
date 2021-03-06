﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise
{
    public abstract class BaseCardSubtitle : BaseTextComponent
    {
        #region Members

        private int size = 6;

        #endregion

        #region Methods

        protected override void BuildClasses( ClassBuilder builder )
        {
            builder.Append( ClassProvider.CardSubtitle() );
            builder.Append( ClassProvider.CardSubtitleSize( Size ) );

            base.BuildClasses( builder );
        }

        #endregion

        #region Properties

        /// <summary>
        /// Number from 1 to 6 that defines the subtitle size where the smaller number means larger text.
        /// </summary>
        /// <remarks>
        /// todo: change to enum
        /// </remarks>
        [Parameter]
        public int Size
        {
            get => size;
            set
            {
                size = value;

                DirtyClasses();
            }
        }

        #endregion
    }
}
