#------------------------------------------------------------------
# Author: ZhangYuehao
# Email: yuehaozhang@njtech.edu.cn
# Zhihu: https://www.zhihu.com/people/bu-meng-cheng-kong-46/posts
# GitHub: https://github.com/ZhangAilan
#-------------------------------------------------------------------
# Date: 2024/07/03
# Function:
#   Clip the voronoi layer with the boundary of the buffer layer
#-------------------------------------------------------------------
# -*- coding: utf-8 -*-
import arcpy
import os
import sys

def clip_layers(target_layer_path, clip_layer_path, output_path):
    try:
        arcpy.env.overwriteOutput = True
        
        # Generate new output path with new file name
        output_directory = os.path.dirname(output_path)
        new_file_name = os.path.splitext(os.path.basename(output_path))[0] + "_Clipped.shp"
        new_output_path = os.path.join(output_directory, new_file_name)

        # Perform the clip operation
        arcpy.Clip_analysis(target_layer_path, clip_layer_path, new_output_path)

        # Return the path to the clipped shapefile
        return new_output_path
    except arcpy.ExecuteError as ex:
        print("Error performing clip operation: ", ex)
        return None

if __name__ == "__main__":
    if len(sys.argv) != 4:
        print("Usage: clip_layers.py <target_layer_path> <clip_layer_path> <output_path>")
    else:
        target_layer_path = sys.argv[1]
        clip_layer_path = sys.argv[2]
        output_path = sys.argv[3]
        result = clip_layers(target_layer_path, clip_layer_path, output_path)
        if result:
            print("Clipped layer created at: " + result)
        else:
            print("Clip operation failed.")
