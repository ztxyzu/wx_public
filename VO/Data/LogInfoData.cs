﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WxPay2017.API.VO
{
    public partial class LogInfoData
    {
        public int Id { get; set; }

        public int? MeterId { get; set; }

        public int? GroupId { get; set; }

        public int? ActionId { get; set; }

        public DateTime? UpdatingTime { get; set; }

        public bool? IsSuccess { get; set; }

        public string OperatorId { get; set; }

        public string OperatorName { get; set; }

        public string ConfigName { get; set; }
    }
}
