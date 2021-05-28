
    window.onload = function(){
            var imglist = document.getElementById("imglist");
            // =======图片盒子下的图片获取==============
            var imgArr = imglist.getElementsByTagName("img");
            // =======图片盒子下的图片获取==============
            imglist.style.width = 1250*imgArr.length + "px";
        
       var navDiv = document.getElementById("navDiv");
       var outer = document.getElementById("outer");
       navDiv.style.left = (outer.offsetWidth - navDiv.offsetWidth)/2+"px"     
      
        var index = 0;
        // =============== 是navDiv的ID下的a链接 ==============
        var allA = navDiv.getElementsByTagName("a");
        // =============== 是navDiv的ID下的a链接 ==============
        allA[index].style.backgroundColor = "black"; 
       
        for(var i =0; i<allA.length;i++)
        {
            //为每一个超链接都添加一个num属性
            allA[i].num = i;
            //为所有超链接都绑定单击响应函数
            allA[i].onclick = function(){
                
                //获取点击超链接的索引
                 index = this.num;

                 //切换图片
                 $("#imglist img").animate({
                    left:-1250*index +"px"
                 },1000);
                // imglist.style.left = -520*index + "px";
                setA(index);

            };
        }
     function showImg()
     {
           setInterval(function(){
            index++;
            // index %= imgArr.length;
            // 如果索引大于当前的索引最大值，就从0开始
            if(index > imgArr.length - 1)
            {
                index = 0;
            }
            console.log(index);
            $("#imglist img").animate({
                left:-1250*index +"px"
            },1000);
            // setA(index);
            // =============== 对应索引的a标签加背景 ==============
            for(var i=0;i<allA.length;i++)
            {
                allA[i].style.backgroundColor = "";
            }
            allA[index].style.backgroundColor = "black";
            // =============== 对应索引的a标签加背景 ==============
           },3000);
          
     }
     showImg();
        function setA(index){
            for(var i=0;i<allA.length;i++)
            {
                allA[i].style.backgroundColor = "";
            }
            allA[index].style.backgroundColor = "black";
        }
    };
       
