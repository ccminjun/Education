#!/bin/bash

array=("APPLE" 200 3.14 400 "지옥으로 키티" 600)   

echo array[*] ==============================
for Temp in "${array[*]}"
do
	echo $Temp
	echo -----
done

echo ==========================================

echo array[@] ==============================
for Temp in "${array[@]}"
do
	echo $Temp
	echo -----
done

