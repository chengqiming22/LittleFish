namespace LittleFish.LabSystem.DataModel.Migrations
{
    using LittleFish.LabSystem.DataModel.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LittleFish.LabSystem.DataModel.LabDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LittleFish.LabSystem.DataModel.LabDbContext context)
        {
            var categories = context.Set<ResourceCategory>();
            categories.RemoveRange(categories.ToList());
            categories.AddRange(new ResourceCategory[]{
                new ResourceCategory
                {
                    Name = "Lab",
                    DisplayName = "ʵ��������",
                    Resources = new List<Resource>
                    {
                        new Resource{Name="LabList", DisplayName="ʵ������Ϣ", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="��������", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="ʵ����ԤԼ", Type= ResourceType.Page}
                    }
                },
                new ResourceCategory
                {
                    Name = "Instrument",
                    DisplayName = "�����豸����",
                    Resources = new List<Resource>
                    {
                        new Resource{Name="LabInfo", DisplayName="�����豸����", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="�����豸�嵥", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="���", Type= ResourceType.Page},
                        new Resource{Name="LabInfo", DisplayName="����", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="ʹ�ü�¼", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="��������", Type= ResourceType.Page},
                        new Resource{Name="LabInfo", DisplayName="ά������", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="�����豸�궨", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="��������", Type= ResourceType.Page},
                        new Resource{Name="LabInfo", DisplayName="��������", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="��������", Type= ResourceType.Page}
                    }
                },
                new ResourceCategory
                {
                    Name = "Consumables",
                    DisplayName = "�Ĳ�����",
                    Resources = new List<Resource>
                    {
                        new Resource{Name="LabInfo", DisplayName="�Ĳķ���", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="�Ĳ��嵥", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="���", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="����", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="��������", Type= ResourceType.Page}
                    }
                },
                new ResourceCategory
                {
                    Name = "System",
                    DisplayName = "ϵͳ����",
                    Resources = new List<Resource>
                    {
                        new Resource{Name="LabInfo", DisplayName="��������", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="���û�ע��", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="�û�����", Type= ResourceType.Page},
                        new Resource{Name="LabInfo", DisplayName="ϵͳ��־", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="�ʼ�����", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="�û�������Ϣ", Type= ResourceType.Page}
                    }
                }});
        }
    }
}
