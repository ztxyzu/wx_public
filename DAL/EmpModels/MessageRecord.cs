//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace  WxPay2017.API.DAL.EmpModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message.MessageRecord")]
    public partial class MessageRecord
    {
        public MessageRecord()
        {
        }
        public int Id { get; set; }

        public int MessageId { get; set; }

        [Required]
        [StringLength(128)]
        public string UserId { get; set; }

        public bool IsReaded { get; set; }

        public bool IsEnable { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? ReadedTime { get; set; }

        public virtual Message Message { get; set; }

        public virtual User User { get; set; }
    }
}