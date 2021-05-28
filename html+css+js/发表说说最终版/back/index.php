<?php
    $content = !empty($_COOKIE["content"]) ? $_COOKIE["content"]:[];
    if(!empty($content))
    {
        $content = object_array($content);
    }
    print_r($content);

    function object_array($array) {  
        if(is_object($array)) {  
            $array = (array)$array;  
         } if(is_array($array)) {  
             foreach($array as $key=>$value) {  
                 $array[$key] = object_array($value);  
                 }  
         }  
         return $array;  
    }