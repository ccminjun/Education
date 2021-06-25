#!/bin/sh
if [ -r /etc/passwd ]
then
	echo "읽기 가능합니다"
else
	echo "읽기 불가능합니다"
fi
