w = 1080 / 19 + 1
m = 0
while w > 0:
    w = (1080 - (49*m)) / 19
    c = 120 - m - w
    if (w == int(w)
        and m == int(m)
        and c == int(c)):
        print("Women:",int(w),
              "  Men:",int(m),
              "  Children:",int(c))
    m = m + 1
