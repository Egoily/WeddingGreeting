using System;

namespace ee.Models
{
    /// <summary>
    /// 贵宾信息
    /// </summary>
    public class GuestInfo
    {
        public virtual string Id { get; set; }
        public virtual string ParentId { get; set; }
        public virtual string Name { get; set; }

        /// <summary>
        /// 性别:0未定义,1男,2女
        /// </summary>
        public virtual int Gender { get; set; }

        public virtual DateTime? Birthday { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public virtual string Labels { get; set; }

        /// <summary>
        /// 贵宾类型(0其他方,1新郎方,2,新娘方)
        /// </summary>
        public virtual int GuestType { get; set; }

        /// <summary>
        /// 随行人员(以逗号分隔)
        /// </summary>
        public virtual string Entourage { get; set; }

        /// <summary>
        /// 随行人人数
        /// </summary>
        public virtual int EntourageNum { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        public virtual string TableNo { get; set; }

        /// <summary>
        /// 座位号
        /// </summary>
        public virtual int SeatNo { get; set; }

        /// <summary>
        /// 是否已出席
        /// </summary>
        public virtual bool IsAttend { get; set; }
        /// <summary>
        /// 签到时间
        /// </summary>
        public virtual DateTime? AttendTime { get; set; }
        /// <summary>
        /// 相片路径
        /// </summary>
        public virtual string ImagePath { get; set; }


        public virtual DateTime CreateTime { get; set; }
    }
}