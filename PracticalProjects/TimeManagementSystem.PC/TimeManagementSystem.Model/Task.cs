using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagementSystem.Model.Enums;

namespace TimeManagementSystem.Model
{
    public class Task
    {
        public string Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 任务类型
        /// </summary>
        public TaskTypeEnum TaskType { get; set; }
        /// <summary>
        /// 任务性质
        /// </summary>
        public TaskPropertyEnum TaskProperty { get; set; }
        /// <summary>
        /// 截止时间
        /// </summary>
        public DateTime Deadline { get; set; }
        /// <summary>
        /// 提醒时间
        /// </summary>
        public TimeSpan RemindTime { get; set; }
        /// <summary>
        /// 是否重复提醒
        /// </summary>
        public bool IsRepeate { get; set; }
        /// <summary>
        /// 是否开启任务进度
        /// </summary>
        public bool IsTurnOnTaskProgress { get; set; }
        /// <summary>
        /// 总任务量
        /// </summary>
        public int TotalNumberOfTask { get; set; }
        /// <summary>
        /// 当前任务量  默认为0
        /// </summary>
        public int CurrentNumberOfTask { get; set; }
        /// <summary>
        /// （可选）每次完成任务量
        /// </summary>
        public int EveryNumberOfTask { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public TaskStatusEnum TaskStatus { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string Description { get; set; }
    }
}
