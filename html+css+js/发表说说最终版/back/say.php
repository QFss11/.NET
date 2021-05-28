<?php
    Session_start();   

    // error_reporting(0);
    // 获取请求
    if(!empty($_REQUEST))
    {
        // 先去获取文件内容回来
        // $file = fopen("say.txt","w");
        
        //获取已经有的内容回来
        // $con = file_get_contents("./say.txt");
        $con = !empty($_COOKIE["content"]) ? $_COOKIE['content'] : "";
        $list = [];
        // 清空缓存
        // $_COOKIE["content"] = "";
        $index = 0; //第一条数据的索引默认为0
        if(!empty($_COOKIE["content"]))
        {
            //将json字符串还原成数组
            $list = json_decode($con,TRUE);  
            // 取出最后的索引回来
            $index = $list[count($list)-1]["id"]++;
        }

        $arr = [];
        // 索引
        $arr["id"] = $index;
        //获取文本内容
        $arr['content'] = !empty($_REQUEST['content'])?$_REQUEST['content']:"hello，world!";
        // 随机生成用户的id
        $arr['uid'] = rand(0,8); //随机生成1到8的数字
        // 名字列表
        $names = [
            "花少爷",
            "琉忆",
            "美少女",
            "假面超人",
            "奥特曼拯救地球",
            "杜兰特",
            "欧文",
            "科比是我偶像",
            "詹姆斯好帅"
        ];
        // 用户名
        $arr['user'] = $names[$arr['uid']];
        // 发表时间
        $arr['time'] = !empty($_REQUEST["time"]) ? $_REQUEST['time'] : date("Y-m-d H:i:s");
        // 头像
        $arr['head'] = "./img/".$arr["uid"].".jpg";

        //将新的内容放进对应的id中
        $list[$index] = $arr;

        // 转换成json字符串存储
        $list = json_encode($list);
        //用session存储内容
        // $_COOKIE["content"] = $list;
        setcookie("content",$list,time()+24*60*60*10);
        echo $list;
        $result = [
            "code" => 200,
            "msg" => "发表说说成功！"
        ];
    }
    else
    {
        $result = [
            "code" => 202,
            "msg" => "非法请求！"
        ];
    }
    echo json_encode($result);

