#!/bin/bash
for ((i=1; i<10; i++))
do
	for ((k=1; k<10; k++))
	do
		echo "$i * $k = `expr $i \* $k`"
	done
done
