#!/bin/sh
if [ -w /bin/ls ]
then
	echo "쓰기 가능합니다"
else
	echo "쓰기 불가능합니다"
fi
