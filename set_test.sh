#!/bin/bash

set $(date)

echo 년도: $1
echo 크기: $#
trap 'echo "$LINENO : VAL=$VAL"' DEBUG

for VAL in $@

do
	echo $VAL
done
