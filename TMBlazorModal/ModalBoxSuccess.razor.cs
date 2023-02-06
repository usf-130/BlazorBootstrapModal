using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TMBlazorModal
{
    public partial class ModalBoxSuccess
    {
        /// <summary>
        /// عنوان 
        /// </summary>
        [Parameter] public string Title { get; set; } = "Your work has been saved";
        /// <summary>
        /// توضیحات
        /// </summary>
        [Parameter] public string Message { get;set; }
        /// <summary>
        /// آیکن Modal - پیشفرض bx-check فعال است
        /// </summary>
        [Parameter] public string Icon { get; set; } = "bx-check";

        /// <summary>
        /// حالت انیمیشن مدال - پیشفرض فعال است
        /// </summary>
        [Parameter] public bool FadeModalAnimation { get; set; } = true;
        /// <summary>
        /// زمان بسته شدن مدال - پیشفرض 2500
        /// </summary>
        [Parameter] public int Timer { get; set; } = 2500;

        /// <summary>
        /// نمایش محتوای Html 
        /// </summary>
        [Parameter] public RenderFragment BodyHtmlContent { get; set; }

        /// <summary>
        /// پنهان کردن آیکن
        /// </summary>
        [Parameter] public bool HideIcon { get; set; }

        /// <summary>
        /// اندازه فونت عنوان- پیشفرض 26
        /// </summary>
        [Parameter] public int TitleFontSize { get; set; } = 26;

        public bool DisposeModal { get; set; }
        public string ModalClass { get; set; } = "fade";

        public string ModalDisplay = "none;";

        public bool Backdrop = false;

        public async Task Open()
        {
            DisposeModal = false;
            ModalDisplay = "block";
            ModalClass = "show";
            Backdrop = false;
            StateHasChanged();
            Task.Run(async () =>
            {
                await Task.Delay(Timer);
                Close();
            });
        }

        public async Task Close()
        {
            ModalDisplay = "none";
            ModalClass = "hide";
            Backdrop = false;
            StateHasChanged();

        }

        public async Task CloseAndDispose()
        {
            DisposeModal = true;
            ModalDisplay = "none";
            ModalClass = "";
            Backdrop = false;
            StateHasChanged();
        }
    }
}

