$(function () {
    $("#msdiv").mSelect({
        data: [{
            Field: "Brand",
            Name: "商标",
            Item: [{ value: "len", text: "lenovo" }, { value: "Ace", text: "Acer" }, { value: "Sum", text: "Sumsan" }], //列表数据
            hasMore: [{ value: "H", text: "HP" }, { value: "shenzhou", text: "神舟" }, { value: "DE", text: "DELL" }], //更多的列表数据
            isMulti: true //当前的字段的值是否支持多选
        }, {
            Field: "Price",
            Name: "价格",
            Item: [{ value: 1, text: "<3000" }, { value: 2, text: "4000-5000" }, { value: 3, text: "5000-7000" }],
            hasMore: [{ value: 4, value: "7000-8000" }, { value: 5, text: "8000-12000" }],
            isMulti: false
        }, {
            Field: "Type1",
            Name: "类型1",
            Item: ["filter1", "filer1_1", "filter1_2", "filer1_3"],
            isMulti: true
        }, {
            Field: "Type2",
            Name: "类型2",
            Item: ["filter2", "filer2_1", "filter2_2", "filer2_3"],
            isMulti: false
        }], //数据格式
        //isAll:true,//是否包括全选，废弃不用
        optionFunc: function (value, index) { //修改数据的值，可以自定义HTML.如添加图片
            //                if(value=="lenovo")
            //                {
            //                    return "<img src='https://ss2.bdstatic.com/9rUZbzqaKgQFm2e88IuM_a/resource/fFhO6R-C0CBiZmAS9VsRZIk30WXQhaSC0mTQ9VsRhV0W0VsS0CXQZdRenFvkrUZwBmhMBmsenGv3XURbBWZSBmZaBUkL.jpg'/>";
            //                }
            return value;
        },
        onHover: function (target) { //在上面滑动时事件，缺省无效果，参数为当前的节点
            //                console.log(target.text());
        },
        onClick: function (target, filter, domList) {
            //每点击一次的事件，参数为当前节点，当前所有选择的条件，所有选择的DOM，便于后期扩展
            alert(target.text() + "  " + JSON.stringify(filter));
        }
    });
});