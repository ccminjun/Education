#!/bin/bash

function RetValue
{
	echo "RetValue"
	return 100
}

RetValue
TEMP=${?}
echo "함수 반환값1 [${?}]"
echo "함수 반환값2 [${TEMP}]"
echo "함수 반환값1 [${?}]"
