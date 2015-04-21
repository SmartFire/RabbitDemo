using Rabbit.Kernel.Localization;
using Rabbit.Web.UI.Navigation;

namespace Rabbit.ModuleManager
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
            const string area = "Rabbit.ModuleManager";
            builder.Add(T("ϵͳ����"),
                menu =>
                    menu
                        .Position("1.1")
                        .LocalNavigation()
                        .Add(T("ģ�����"), i => i.Action("Index", "Admin", new { Area = area }).LocalNavigation())
                );
        }

        /// <summary>
        /// �����˵����ơ�
        /// </summary>
        public string MenuName { get { return "admin"; } }

        #endregion Implementation of INavigationProvider
    }
}