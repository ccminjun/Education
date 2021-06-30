#!/bin/bash

Value1="지옥으로 키티"
Value2="Value1"

echo 'Value1    = ' $Value1      # 지옥으로 키티
echo 'Value2    = ' $Value2      # Value1
echo '${!Value} = ' ${!Value2}   # 지옥으로 키티
