#!/bin/bash
for Dan in 3 5 6 9
do
	for ((i=1; i<10; i++))
	do
		echo "$Dan * $i = `expr $Dan \* $i`"
	done
done
