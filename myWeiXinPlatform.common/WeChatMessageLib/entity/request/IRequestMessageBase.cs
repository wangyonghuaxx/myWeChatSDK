﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWeiXinPlatform.common
{
    public interface IRequestMessageBase : IMessageBase
    {
        RequestMsgType MsgType { get; }

        long MsgId { get; set; }
    }
}
