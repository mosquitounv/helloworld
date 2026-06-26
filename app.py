import tkinter as tk
from tkinter import scrolledtext


def say_hello():
    log.insert(tk.END, "hello mosquito\n")
    log.see(tk.END)  # 自动滚动到底部


root = tk.Tk()
root.title("我的小程序")
root.geometry("420x400")
root.resizable(True, True)

# 点我按钮
btn = tk.Button(root, text="点我", font=("Microsoft YaHei", 14, "bold"),
                width=10, height=1, command=say_hello)
btn.pack(pady=15)

# 日志窗口
log = scrolledtext.ScrolledText(root, font=("Consolas", 11),
                                wrap=tk.WORD, state="normal")
log.pack(fill=tk.BOTH, expand=True, padx=15, pady=10)

root.mainloop()
