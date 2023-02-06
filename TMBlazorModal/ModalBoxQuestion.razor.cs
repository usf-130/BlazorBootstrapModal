using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMBlazorModal
{
    public partial class ModalBoxQuestion
    {
        /// <summary>
        /// نمایش عنوان
        /// </summary>
        [Parameter] public string Title { get; set; }

        /// <summary>
        /// غیر فعال کردن نمایش دکمه انصراف
        /// </summary>
        [Parameter] public string CancelButtonText { get; set; } = "Cancel";

        /// <summary>
        /// متن دکمه ارسال 
        /// </summary>
        [Parameter] public string ConfirmButtonText { get; set; } = "Confirm";

       
        /// <summary>
        /// نام آیکن (boxicons.com)
        /// </summary>
        [Parameter] public string Icon { get; set; } = "bx-question-mark";

        /// <summary>
        /// توضیحات برای نمایش در ModalBox
        /// </summary>
        ///
        [Parameter] public string? Message { get; set; }

        /// <summary>
        ///  نمایش محتوای Html 
        /// </summary>
        [Parameter] public RenderFragment BodyHtmlContent { get; set; }
        /// <summary>
        /// فعال سازی انیمیشن fade مدال باکس
        /// </summary>
        [Parameter] public bool FadeModalAnimation { get; set; }
        /// <summary>
        /// فعال سازی زمینه پشت مدال - پیشفرض فغال
        /// </summary>
        [Parameter] public bool DisableBackdrop { get; set; } = false;
        /// <summary>
        /// فعال سازی نمایش آیکن - پیشفرض فعال
        /// </summary>
        [Parameter] public bool HideIcon { get; set; } = false;

        /// <summary>
        /// فعال سازی نمایش دکمه کنسل - پیشفرض فعال
        /// </summary>
        [Parameter] public bool HideCanselButton { get; set; } = false;
        /// <summary>
        /// فعال سازی نمایش دکمه ارسال - پیشفرض فعال
        /// </summary>
        [Parameter] public bool HideConfirmButton { get; set; } = false;

        /// <summary>
        /// کلاس دکمه کنسل - پیشفرض btn-danger
        /// </summary>
        [Parameter] public string CanselButtonClass { get; set; } = "btn-danger";
        /// <summary>
        /// کلاس دکمه ارسال - پیشفرض btn-primary
        /// </summary>
        [Parameter] public string ConfirmButtonClass { get; set; } = "btn-primary";
        /// <summary>
        /// سایز فونت عنوان - برای مثال 18
        /// </summary>
        [Parameter] public int TitleFontSize { get; set; } = 22;

        /// <summary>
        /// دریافت بازخورد دکمه کنسل
        /// </summary>
        [Parameter] public EventCallback Cansel { get; set; }
        /// <summary>
        /// دریافت بازخورد دکمه ارسال
        /// </summary>
        [Parameter] public EventCallback Confirm { get; set; }


        public bool DisposeModal { get; set; }
        public string ModalAnimationClass { get; set; } = "fade";
        public bool Backdrop = false;
        public string ModalDisplay = "none;";

        public async Task Open()
        {
            DisposeModal = false;
            ModalDisplay = "block";
            ModalAnimationClass = "show";
            Backdrop = true;
            StateHasChanged();
            //  await SubmitModal.InvokeAsync();
        }

        public void Close()
        {
            ModalDisplay = "none";
            ModalAnimationClass = "hide";
            Backdrop = false;
            StateHasChanged();
            //   CloseModal.InvokeAsync();
        }

        public async Task CloseAndDispose()
        {
            DisposeModal = true;
            ModalDisplay = "none";
            ModalAnimationClass = "";
            Backdrop = false;
            StateHasChanged();
            // await CloseModal.InvokeAsync();
        }

    }
}
