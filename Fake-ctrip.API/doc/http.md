# HTTP

## 1. 内容协商与数据格式

1. 请求头部的媒体类型定义“accept”与“content-type”
	application/JSON、application/xml
	遇到无法识别的格式，返回错误代码 406 unacceptable
2. ASP.NET Core支持内容协商，自动化处理



# 2.HTTP HEAD

- HEAD与GET类似，但没有response body
- 检测缓存
- 探测资源是否存在



# 3.【复合搜索】深入理解GET请求

- 传递API参数
- 关键词搜索
- 数据过滤
- 参数封装，统一管理

向API传入参数，使用Attribute：[[FromXXX]

|   Attribute   |                         参数来源                         |
| :-----------: | :------------------------------------------------------: |
|  [FromQuery]  | 请求url的参数字符串，https://xxx.com/search?id=1&age=18  |
|  [FromBody]   |                       请求主体数据                       |
|  [FromForm]   |    请求主体的表单数据(IFormFile, IFormFileCollection)    |
|  [FromRoute]  | MVC架构下的Route路由URL的参数，https://xxx.com/users/123 |
| [FromService] |                数据来源于已注入的服务依赖                |

