#------------------------------------------------------------------
# Author: ZhangYuehao
# Email: yuehaozhang@njtech.edu.cn
# Zhihu: https://www.zhihu.com/people/bu-meng-cheng-kong-46/posts
# GitHub: https://github.com/ZhangAilan
#-------------------------------------------------------------------
# Date: 2024/07/03
# Function:
#   Create Thiessen polygons
#-------------------------------------------------------------------
# -*- coding: utf-8 -*-
import arcpy
import sys

def create_thiessen_polygons(input_shp, output_shp):
    arcpy.env.workspace = arcpy.env.scratchGDB
    arcpy.analysis.CreateThiessenPolygons(input_shp, output_shp, "ALL")

if __name__ == "__main__":
    input_shp = sys.argv[1]
    output_shp = sys.argv[2]
    create_thiessen_polygons(input_shp, output_shp)
