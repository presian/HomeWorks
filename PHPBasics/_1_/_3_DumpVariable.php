<?php

function variable($param) {
    if (is_numeric($param)) {
        echo var_dump($param);
    } else {
        echo gettype($param)."<br />";
    }
}
variable("hello");
variable(15);
variable(1.234);
variable(array(1,2,3));
variable((object)[2,34]);

