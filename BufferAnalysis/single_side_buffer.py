#------------------------------------------------------------------
# Author: ZhangYuehao
# Email: yuehaozhang@njtech.edu.cn
# Zhihu: https://www.zhihu.com/people/bu-meng-cheng-kong-46/posts
# GitHub: https://github.com/ZhangAilan
#-------------------------------------------------------------------
# Date: 2024/07/03
# Function:
#   create a single side buffer
#   "LEFT" "RIGHT" --line
#   "OUTSIDE_ONLY" "INSIDE_ONLY" --polygon
#-------------------------------------------------------------------
# -*- coding: utf-8 -*-

import arcpy
import sys

def create_one_side_buffer(line_feature_path, output_path, distance, side):
    side_options = {
        "LEFT": "LEFT",
        "RIGHT": "RIGHT",
        "OUTSIDE_ONLY": "OUTSIDE_ONLY",
        "INSIDE_ONLY": "INSIDE_ONLY"
    }
   
    side_option = side_options.get(side.upper(), "FULL")
   
    arcpy.Buffer_analysis(
        in_features=line_feature_path,
        out_feature_class=output_path,
        buffer_distance_or_field=distance,
        line_side=side_option
    )

if __name__ == "__main__":
    line_feature_path = sys.argv[1]
    output_path = sys.argv[2]
    distance =sys.argv[3]
    side = sys.argv[4]
   
    create_one_side_buffer(line_feature_path, output_path, distance, side)
