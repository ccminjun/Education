#!/bin/sh

COMMAND="ls -al"

echo "=========================================="
echo ${COMMAND}
echo "=========================================="
eval ${COMMAND}
echo "=========================================="
echo `${COMMAND}`
