#------------------------------------------------------------------
# Author: ZhangYuehao
# Email: yuehaozhang@njtech.edu.cn
# Zhihu: https://www.zhihu.com/people/bu-meng-cheng-kong-46/posts
# GitHub: https://github.com/ZhangAilan
#-------------------------------------------------------------------
# Date: 2024/07/03
# Function:
#   create the distance changing buffer
#-------------------------------------------------------------------
# -*- coding: utf-8 -*-

import arcpy
import sys

def create_variable_buffer(input_shp, distance_field, output_shp):
    try:
        arcpy.env.overwriteOutput = True
        
        arcpy.Buffer_analysis(in_features=input_shp,
                              out_feature_class=output_shp,
                              buffer_distance_or_field=distance_field,
                              line_side="FULL",
                              line_end_type="ROUND",
                              dissolve_option="NONE",
                              dissolve_field=None)
    except Exception as e:
        print(e)

if __name__ == "__main__":
    input_shp = sys.argv[1]
    distance_field = sys.argv[2]
    output_shp = sys.argv[3]
    
    create_variable_buffer(input_shp, distance_field, output_shp)