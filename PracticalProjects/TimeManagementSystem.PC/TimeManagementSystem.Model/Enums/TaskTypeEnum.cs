using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagementSystem.Model.Enums
{
    public enum TaskTypeEnum
    {
        /// <summary>
        /// 紧急重要
        /// </summary>
        EmergencyAndImportant=1,
        /// <summary>
        /// 紧急不重要
        /// </summary>
        EmergencyAndUnimportant =2,
        /// <summary>
        /// 不紧急重要
        /// </summary>
        UnemergencyAndImportant =3,
        /// <summary>
        /// 不紧急不重要
        /// </summary>
        UnemergencyAndUnimportant =4
    }
}
