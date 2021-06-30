#!/bin/bash

echo "2부터 100까지의 소수값은"

for((j=2; j<=100; j++))
do
	for((i=2; i<=j-1; i++))
	do
		if((j%i==0))
		then
			break
		fi
	done

	if ((i==j))
	then 
		printf "$j "
	fi
done
