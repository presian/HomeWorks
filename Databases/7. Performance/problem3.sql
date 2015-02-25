/*CREATE TABLE `performance_tunings`.`then_mil` (
  `record_id` INT NOT NULL AUTO_INCREMENT,
  `record_date` DATETIME NOT NULL,
  `record_text` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`record_id`, `record_date`))
ENGINE = InnoDB
PARTITION BY RANGE ( YEAR(record_date) ) (
    PARTITION p0 VALUES LESS THAN (2014),
    PARTITION p1 VALUES LESS THAN (2015),
    PARTITION p3 VALUES LESS THAN MAXVALUE
);*/




/*delimiter #
create procedure load_test_data()
begin

declare v_max int unsigned default 1000000;
declare v_counter int unsigned default 0;
  start transaction;
  while v_counter < v_max do
    insert into then_mil (record_date, record_text) 
    values ( date_sub( now(),INTERVAL v_counter minute), 'abc');
    set v_counter=v_counter+1;
  end while;
  commit;
end #

delimiter ;*/

/*call load_test_data()*/


/*select *
from performance_tunings.then_mil
where  record_date BETWEEN '2014-12-30' AND '2015-01-2';*/


/*select *
from performance_tunings.then_mil
where  record_date BETWEEN '2015-1-1' AND '2015-01-4';*/
















