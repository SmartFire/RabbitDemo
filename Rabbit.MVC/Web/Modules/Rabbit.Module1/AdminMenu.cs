using Rabbit.Kernel.Localization;
using Rabbit.Web.UI.Navigation;

namespace Rabbit.Module1
{
    internal sealed class AdminMenu : INavigationProvider
    {
        public AdminMenu()
        {
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }

        #region Implementation of INavigationProvider

        /// <summary>
        /// ��ȡ������
        /// </summary>
        /// <param name="builder">���������ߡ�</param>
        public void GetNavigation(NavigationBuilder builder)
        {
            const string area = "Rabbit.Module1";
            builder.Add(T("ģ��1"),
                menu =>
                    menu
                        .Position("1.2")
                        .LocalNavigation()
                        .Add(T("Module1"), i => i.Action("Index", "Admin", new { Area = area }).LocalNavigation())
                );
        }

        /// <summary>
        /// �����˵����ơ�
        /// </summary>
        public string MenuName { get { return "admin"; } }

        #endregion Implementation of INavigationProvider
    }
}