#!/bin/bash

PASS="BNK GROUP"
INPUT=
while [ "$PASS" != "$INPUT" ]
do
	printf "$PASS를 입력하세요 : "
	read INPUT
done
echo "스크립트를 종료합니다"
