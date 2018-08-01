﻿using System.Collections.Generic;

namespace Baidu.AI.Face
{
    public static class Dictionaries
    {
        /// <summary>
        /// 人脸识别 错误词典
        /// </summary>
        public static readonly Dictionary<int, string> ErrorDictionary = new Dictionary<int, string>()
        {
            {4,"集群超限额" },
            {17,"每天流量超限额" },
            {18,"QPS超限额"},
            {19,"请求总量超限额" },
            {100,"无效参数" },
            {110,"Access Token失效" },
            {111,"Access Token过期" },
            {216015,"模块关闭" },
            {216100,"参数异常" },
            {216101,"缺少必须的参数" },
            {216102,"请求了不支持的服务_请检查调用的url" },
            {216103,"请求超长_一般为一次传入图片个数超过系统限制" },
            {216110,"appid不存在_请重新检查后台应用列表中的应用信息" },
            {216111,"userid信息非法_请检查对应的参数" },
            {216200,"图片为空或者base64解码错误" },
            {216201,"图片格式错误"},
            {216202,"图片大小错误"},
            {216300,"数据库异常_少量发生时重试即可" },
            {216400,"后端识别服务异常_可以根据具体msg查看错误原因"},
            {216401,"内部错误" },
            {216402,"未找到人脸_请检查图片是否含有人脸" },
            {216500,"未知错误" },
            {216611,"用户不存在_请确认该用户是否注册或注册已经生效" },
            {216613,"删除用户图片记录失败_重试即可" },
            {216614,"两两比对中图片数少于2张_无法比较"},
            {216615,"服务处理该图片失败_发生后重试即可" },
            {216616,"图片已存在" },
            {216617,"新增用户图片失败" },
            {216618,"组内用户为空_确认该group是否存在或已经生效" },
            {216631,"本次请求添加的用户数量超限" }
        };
    }
}