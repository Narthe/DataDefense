#!/bin/bash

rm *.aux
rm *.log
rm *.pdf
latex --output-format=pdf cdc.tex
evince cdc.pdf
