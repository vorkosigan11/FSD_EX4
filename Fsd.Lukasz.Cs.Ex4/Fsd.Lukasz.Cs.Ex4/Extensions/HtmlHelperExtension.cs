using System.Web.Mvc;

namespace Fsd.Lukasz.Cs.Ex4.Extensions
{
    public static class HtmlHelperExtension
    {
        #region Methods

        public static MvcHtmlString MailTo(this HtmlHelper helper, string email)
        {
            if (string.IsNullOrEmpty(email))
                return MvcHtmlString.Create("");
            else
                return MvcHtmlString.Create($"<a href='mailto:{email}'>{email}</a>");
        }

        #endregion Methods
    }
}