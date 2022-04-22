#!/bin/bash

echo "년도를 입력하세요"
read YEAR

if [ `expr $YEAR \% 100` != 0 ] && [ `expr $YEAR \%  4` = 0 ] || [ `expr $YEAR \% 400` = 0 ]
then 
	echo "$YEAR 년은 윤년입니다."
else 
	echo "$YEAR 년은 윤년이 아닙니다."
fi


