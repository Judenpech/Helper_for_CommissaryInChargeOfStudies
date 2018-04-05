import xlrd, os, winreg, time


def open_excel(file):
    try:
        data = xlrd.open_workbook(file)
        return data
    except Exception as e:
        print(str(e))


def excel_table_byname(file, colnameindex=0, by_name="Sheet1"):
    data = open_excel(file)
    table = data.sheet_by_name(by_name)  # 获得表格
    nrows = table.nrows  # 表格的总行数
    colnames = table.row_values(colnameindex)  # 第一行数据: ['学号', '姓名']
    list = []
    for rownum in range(1, nrows):  # 从Excel第二行开始
        row = table.row_values(rownum)
        if row:
            app = {}
            for i in range(len(colnames)):
                app[colnames[i]] = row[i]  # 表头与数据对应
            list.append(app)
    return list


def get_files_name(file_dir):
    L = []
    for roots, dirs, files in os.walk(file_dir):
        '''
        if dirs:# 当前路径下所有子目录
            L.append(dirs)
        '''
        if files:  # 当前路径下所有非目录子文件
            for i in files:
                L.append(i)
    return L


def get_desktop():
    key = winreg.OpenKey(winreg.HKEY_CURRENT_USER,
                         r'Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders')  # 利用系统的链表
    return winreg.QueryValueEx(key, "Desktop")[0]  # 返回的是Unicode类型数据


def main():
    print("使用须知".center(60, '-'))
    print("1. 要检查的文件名必须包含学号\n")
    print("-" * 64)

    tables = excel_table_byname(r"C:/Users/jl223/Desktop/15信管通讯录.xls")

    n = eval(input("请选择要进行的操作：\n"
                   + "1. 查找未上交作业的同学\n"
                   + "2. 批量修改/格式化文件名\n"))
    open_dir = r"C:\Users\jl223\Desktop\新建文件夹"

    if n == 1:
        open_List = get_files_name(open_dir)
        TxtPath = get_desktop() + "\\" + time.strftime("%Y%m%d") + "未交同学名单.txt"  # 输出路径
        fobj = open(TxtPath, 'w')
        out = ""
        cnt = 0
        for i in tables:
            t = i["学号"]
            flag = 1
            for j in open_List:
                if j.find(t) != -1:
                    flag = 0
                    break
            if flag:
                cnt += 1
                out += i["学号"] + "  " + i["姓名"] + '\n'
        if cnt == 0:
            out = "已交齐！"
        else:
            out = "未交人数：" + str(cnt) + " 人\n\n未交同学名单如下：\n\n" + out
        fobj.writelines(out)
        fobj.close()
        print("文件已保存成功至桌面！\n文件名为：" + time.strftime("%Y%m%d") + "未交同学名单.txt")
    elif n == 2:
        modi_name = os.listdir(r"C:\Users\jl223\Desktop\新建文件夹")
        cnt = 0
        suscnt = 0
        for j in modi_name:
            cnt += 1
            for i in tables:
                t = i["学号"]
                if j.find(t) != -1:
                    indx = j.find('.')
                    new_name = i["学号"] + "_" + i["姓名"] + j[indx:]
                    suscnt += 1
                    break
            os.rename(r"C:\Users\jl223\Desktop\新建文件夹" + '\\' + str(j),
                      r"C:\Users\jl223\Desktop\新建文件夹" + '\\' + new_name)
        print("重命名文件成功 " + str(suscnt) + " 个，失败 " + str(cnt - suscnt) + " 个。\n")


if __name__ == "__main__":
    main()
