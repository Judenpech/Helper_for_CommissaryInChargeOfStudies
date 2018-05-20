import xlrd
import os
import traceback


def open_excel(file):
    try:
        data = xlrd.open_workbook(file)
        return data
    except Exception as e:
        print(str(e))


def excel_table_byname(file, colnameindex=0, by_name="Sheet1"):  # 获取Excel表格名单
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


def get_files_name(file_dir):  # 获取要检查的文件夹目录下所有文件夹名和文件名
    L = []
    for roots, dirs, files in os.walk(file_dir):
        # dirs 是一个 list ，内容是该文件夹中所有的文件夹的名字(不包括子目录)
        if dirs:
            for d in dirs:
                L.append(d)
        # files是一个list，内容是该文件夹中所有的文件
        if files:
            for f in files:
                L.append(f)
    return L


def check_stu(excel_file="", open_dir=""):  # 作业查交
    tables = excel_table_byname(excel_file)
    filesList = get_files_name(open_dir)
    out = ""
    cnt = 0
    for dic in tables:
        stuNo = dic["学号"]
        flag = 1
        for file in filesList:
            if file.find(stuNo) != -1:
                flag = 0
                break
        if flag:
            cnt += 1
            out += dic["学号"] + "  " + dic["姓名"] + '\n'
    if cnt == 0:
        out = "已交齐！"
    else:
        total = len(tables)
        submit = cnt
        out = "=====作业查交情况=====\n班级总人数：" + str(total) \
              + " 人\n上交作业人数：" + str(total - submit) + " 人\n未交作业人数：" \
              + str(submit) + " 人\n======================\n未交作业同学名单：\n\n" \
              + out
    return out


def modi_all(excel_file="", open_dir="", sep=" "):  # 批量格式化命名
    tables = excel_table_byname(excel_file)
    filesList = os.listdir(open_dir)  # 检查文件夹下的所有文件和文件夹
    cnt = 0
    try:
        for file in filesList:
            for dic in tables:
                stuNo = dic["学号"]
                if file.find(stuNo) != -1:
                    dot = file.rfind('.')
                    if dot != -1:
                        newName = dic["学号"] + sep + dic["姓名"] + file[dot:]
                    elif os.path.isdir(open_dir + '\\' + str(file)):
                        newName = dic["学号"] + sep + dic["姓名"]
                    os.rename(os.path.join(open_dir, file),
                              os.path.join(open_dir, newName))
                    cnt += 1
                    break
        return "批量重命名文件 " + str(cnt) + " 个。"
    except:
        return "批量重命名文件失败！失败原因：\n" + traceback.format_exc()


def add_front(open_dir="", add=""):  # 批量添加文件名前缀
    filesList = os.listdir(open_dir)
    cnt = 0
    try:
        for file in filesList:
            newName = add + file[0:]
            cnt += 1
            os.rename(open_dir + '\\' + str(file),
                      open_dir + '\\' + newName)
        return "批量添加前缀重命名文件 " + str(cnt) + " 个。"
    except:
        return "批量添加前缀重命名文件失败！失败原因：\n" + traceback.format_exc()


def add_back(open_dir="", add=""):  # 批量添加文件名后缀
    filesList = os.listdir(open_dir)
    cnt = 0
    try:
        for file in filesList:
            dot = file.rfind(".")
            if dot != -1:
                newName = file[0:dot] + add + file[dot:]
            else:
                newName = file[0:] + add
            cnt += 1
            os.rename(open_dir + '\\' + str(file),
                      open_dir + '\\' + newName)
        return "批量添加后缀重命名文件 " + str(cnt) + " 个。"
    except:
        return "批量添加后缀重命名文件失败！失败原因：\n" + traceback.format_exc()


def main():
    n = input()
    ls = n.split("$")
    if n[0] == '1':  # 作业查交
        print(check_stu(ls[1], ls[2]))
    elif n[0] == '2':  # 基础重命名
        if ls[1] == '1':  # 指定分隔符
            print(modi_all(ls[2], ls[3], ls[4]))
        elif ls[1] == '2':  # 默认分隔符
            print(modi_all(ls[2], ls[3]))
    elif n[0] == '3':  # 扩展重命名
        if ls[1] == '1':  # 前缀
            print(add_front(ls[2], ls[3], ls[4]))
        elif ls[1] == '2':  # 后缀
            print(add_back(ls[2], ls[3], ls[4]))


if __name__ == '__main__':
    main()
