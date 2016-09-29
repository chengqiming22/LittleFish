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
                    DisplayName = "实验室中心",
                    Resources = new List<Resource>
                    {
                        new Resource{Name="LabList", DisplayName="实验室信息", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="规章守则", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="实验室预约", Type= ResourceType.Page}
                    }
                },
                new ResourceCategory
                {
                    Name = "Instrument",
                    DisplayName = "仪器设备中心",
                    Resources = new List<Resource>
                    {
                        new Resource{Name="LabInfo", DisplayName="仪器设备分类", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="仪器设备清单", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="入库", Type= ResourceType.Page},
                        new Resource{Name="LabInfo", DisplayName="出库", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="使用记录", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="保养中心", Type= ResourceType.Page},
                        new Resource{Name="LabInfo", DisplayName="维修中心", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="仪器设备标定", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="报废申请", Type= ResourceType.Page},
                        new Resource{Name="LabInfo", DisplayName="借用申请", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="购入申请", Type= ResourceType.Page}
                    }
                },
                new ResourceCategory
                {
                    Name = "Consumables",
                    DisplayName = "耗材中心",
                    Resources = new List<Resource>
                    {
                        new Resource{Name="LabInfo", DisplayName="耗材分类", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="耗材清单", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="入库", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="出库", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="购入申请", Type= ResourceType.Page}
                    }
                },
                new ResourceCategory
                {
                    Name = "System",
                    DisplayName = "系统设置",
                    Resources = new List<Resource>
                    {
                        new Resource{Name="LabInfo", DisplayName="个人中心", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="新用户注册", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="用户管理", Type= ResourceType.Page},
                        new Resource{Name="LabInfo", DisplayName="系统日志", Type= ResourceType.Page},
                        new Resource{Name="Regulations", DisplayName="邮件设置", Type= ResourceType.Page},
                        new Resource{Name="LabAppointment", DisplayName="用户反馈信息", Type= ResourceType.Page}
                    }
                }});
        }
    }
}
