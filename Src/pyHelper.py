import xlrd
import os


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


def check_stu(excel_file="", open_dir=""):
    tables = excel_table_byname(excel_file)
    open_List = get_files_name(open_dir)
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
    return out


def modi_all(excel_file="", open_dir="", sep=' '):
    tables = excel_table_byname(excel_file)
    modi_name = os.listdir(open_dir)
    cnt = 0
    suscnt = 0
    for j in modi_name:
        cnt += 1
        for i in tables:
            t = i["学号"]
            if j.find(t) != -1:
                indx = j.find('.')
                new_name = i["学号"] + sep + i["姓名"] + j[indx:]
                suscnt += 1
                break
        os.rename(open_dir + '\\' + str(j),
                  open_dir + '\\' + new_name)
    re = "重命名文件成功 " + str(suscnt) + " 个，失败 " + str(cnt - suscnt) + " 个。\n"
    return re


def add_front(excel_file="", open_dir="", add=' '):
    tables = excel_table_byname(excel_file)
    modi_name = os.listdir(open_dir)
    cnt = 0
    suscnt = 0
    for j in modi_name:
        cnt += 1
        for i in tables:
            t = i["学号"]
            if j.find(t) != -1:
                new_name = add + j[0:]
                suscnt += 1
                break
        os.rename(open_dir + '\\' + str(j),
                  open_dir + '\\' + new_name)
    re = "重命名文件成功 " + str(suscnt) + " 个，失败 " + str(cnt - suscnt) + " 个。\n"
    return re


def add_back(excel_file="", open_dir="", add=' '):
    tables = excel_table_byname(excel_file)
    modi_name = os.listdir(open_dir)
    cnt = 0
    suscnt = 0
    for j in modi_name:
        cnt += 1
        for i in tables:
            t = i["学号"]
            if j.find(t) != -1:
                indx = j.find('.')
                new_name = j[0:indx] + add + j[indx:]
                suscnt += 1
                break
        os.rename(open_dir + '\\' + str(j),
                  open_dir + '\\' + new_name)
    re = "重命名文件成功 " + str(suscnt) + " 个，失败 " + str(cnt - suscnt) + " 个。\n"
    return re


def main():
    n = input()
    l = n.split()
    if n[0] == '1':
        print(check_stu(l[1], l[2]))
    elif n[0] == '2':
        if len(l) == 4:
            print(modi_all(l[1], l[2], l[3]))
        else:
            print(modi_all(l[1], l[2]))
    elif n[0] == '3':
        if l[1] == '1':
            print(add_front(l[2], l[3], l[4]))
        elif l[1] == '2':
            print(add_back(l[2], l[3], l[4]))


if __name__ == '__main__':
    main();
