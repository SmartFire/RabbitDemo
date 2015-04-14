using Rabbit.Kernel.Localization;
using Rabbit.Web.UI.Navigation;

namespace Rabbit.UserInterface
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
            const string area = "Rabbit.UserInterface";
            builder.Add(T("����̨"),
                menu =>
                    menu
                        .Position("1")
                        .LocalNavigation()
                        .Icon("fa fa-fw fa-dashboard")
                        .Add(T("��ҳ"), i => i.Action("Index", "Admin", new { Area = area }).LocalNavigation())
                        .Add(T("��ԱCRM"), i => i.Action("Index", "MemberCrm", new { Area = area }).LocalNavigation()
                            .Add(T("�༭��Ա����"), z => z.Action("Edit", "MemberCrm", new { Area = area })))
                        .Add(T("��Ա������"), i => i.Action("Index", "MemberCardSetting", new { Area = area }).LocalNavigation()
                            .Add(T("�����Ȩ"), z => z.Action("AddPrivilege", "MemberCardSetting", new { Area = area }))
                            .Add(T("�༭��Ȩ"), z => z.Action("EditPrivilege", "MemberCardSetting", new { Area = area })))
                        .Add(T("��Ա������"), i => i.Action("Index", "MemberCardAdmin", new { Area = area }).LocalNavigation()
                            .Add(T("�༭��Ա������"), z => z.Action("Edit", "MemberCardAdmin", new { Area = area })))
                );
        }

        /// <summary>
        /// �����˵����ơ�
        /// </summary>
        public string MenuName { get { return "admin"; } }

        #endregion Implementation of INavigationProvider
    }
}