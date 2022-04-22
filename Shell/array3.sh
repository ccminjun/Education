#!/bin/bash

array=("APPLE" 200 3.14 400 "지옥으로 키티" 600)   

echo ${array[@]}                # 배열 전체
echo ${array[*]}                # 배열 전체
echo ${#array[@]}               # 배열 크기 / 길이 / 요소 개수
echo ${#array[*]}               # 배열 크기 / 길이 / 요소 개수
