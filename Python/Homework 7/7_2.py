def print_operation_table(operation, num_rows=6, num_columns=6):
    for i in range(0,num_rows+1):
        for j in range(1,num_columns+1):
            if operation (i,j)!=0:
                print (operation(i,j),end='\t')
        if operation (i,j)!=0:print ()
print_operation_table(lambda x, y: x + y)