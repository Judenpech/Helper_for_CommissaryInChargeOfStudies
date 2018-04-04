import xlrd,os

#输出路径
TxtPath="C://Users//jl223vy//Desktop//output.txt"

def open_excel(file= 'file.xls'):
    try:
        data = xlrd.open_workbook(file)
        return data
    except Exception as e:
        print(str(e))

def excel_table_byname(file= "C://Users//jl223//Desktop//15信管通讯录.xls", colnameindex=0, by_name="Sheet1"):
     data = open_excel(file)
     table = data.sheet_by_name(by_name) #获得表格
     nrows = table.nrows  # 表格的总行数
     colnames = table.row_values(colnameindex)  # 第一行数据: ['学号', '姓名']
     list = []
     for rownum in range(1, nrows): #从Excel第二行开始
         row = table.row_values(rownum)
         if row:
             app = {}
             for i in range(len(colnames)):
                 app[colnames[i]] = row[i] #表头与数据对应
             list.append(app)
     return list

def Get_files_name(file_dir):
    L=[]
    for roots, dirs, files in os.walk(file_dir):
        if dirs:# 当前路径下所有子目录
            L.append(dirs)
        if files:# 当前路径下所有非目录子文件
            for i in files:
                L.append(i)
    print(L)
    return L

def main():
    tables = excel_table_byname()
    n=eval(input("请选择要进行的操作：\n1 - 查找未上交作业的同学\n"))
    open_dir="C://Users//jl223//Desktop//新建文件夹"
    if n==1:
        open_List = Get_files_name(open_dir)
  #  for row in tables:
   #    print(row)

if __name__ =="__main__":
    main()