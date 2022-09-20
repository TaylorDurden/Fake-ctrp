# restful api



## 1. Restful的6个约束

1. 前后端分离
2. 无状态，请求独立
3. 分层系统，代码分层
4. 统一接口，数据统一，API自我发现
5. 可缓存
6. 按需代码，不重要



## Richardson成熟度模型与HATOAS

> Rest APIs must be hypertext-driven -- Posted by Roy T. Fielding under software architecture, web architecture
>
> 只有使用了超媒体的才能算是真正的REST

Level 0: The Swamp of POX

- 有个api

- 通过http传输数据
- 比如：简单对象访问协议SOAP



Level 1: Resources

	- 面向资源  api/v1/users



Leve 2: HTTP Verbs

- HTTP语法 (GET, POST, PUT, PATCH, DELETE)



Level 3: Hypermedia Controls

- HATEOAS（Hypertext As The Engine Of Application State）超媒体即应用状态引擎的实现
- api的自我发现机制
- 超媒体（Hypermedia）= 多媒体（multimedia）+ 超文本（hypertext）



## RESTful API 范例

- Github
  https://developer.github.com/v3/


## 幂等性

同样的操作不论经过多少次调用，返回的数据、或者产生的效果都是一致的
- a = 1; 幂等
- a++; 不幂等

幂等性是数据概念，表达的是N次交换与1次交换的结果相同