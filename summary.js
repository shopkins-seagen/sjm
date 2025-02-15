            function filterTable() {
                $('#selQCLevel').val('All');
                var val = $('#selIssueLevel').val().toLowerCase();
                $('#t1 > tbody  > tr').each((function (index, tr) {
                    if ('all' != val) {
                        var rowClass = $(this).attr('class');
                        null != rowClass && (rowClass.toLowerCase().includes(val) ? ($(this).removeClass('filteredRow'), $(this).addClass('unfilteredRow')) : ($(this).removeClass('unfilteredRow'), $(this).addClass('filteredRow')))
                    } else 
                        $(this).removeClass('filteredRow'),
                        $(this).addClass('unfilteredRow')
                    
                }))
            }
            function filterTableQc() {
                $('#selIssueLevel').val('All');
                var val = $('#selQCLevel').val().toLowerCase();
                $('#t1 > tbody  > tr').each((function (index, tr) {
                    if ('all' != val) {
                        var rowClass = $(this).attr('class');
                        null != rowClass && (rowClass.toLowerCase().includes(val) ? ($(this).removeClass('filteredRow'), $(this).addClass('unfilteredRow')) : ($(this).removeClass('unfilteredRow'), $(this).addClass('filteredRow')))
                    } else 
                        $(this).removeClass('filteredRow'),
                        $(this).addClass('unfilteredRow')
                    
                }))
            }

            $((function () {
                $('.expandChildTable').on('click', (function () {
                    $(this).toggleClass('selected').closest('tr').next().toggle()
                }))
            }))

            $((function () {
                $('.filterButton').on('click', (function () {

                    $('#selIssueLevel').val($(this).html());
                    filterTable();
                }))
            }))

            $((function () {
                $('.filterQcButton').on('click', (function () {

                    $('#selQCLevel').val($(this).html());
                    filterTableQc();
                }))
            }))

            $((function () {
                $('.tableBtn').on('click', (function () {
                    $(this).toggleClass('selected').closest('tr').next().toggle()
                }))
            }))

            $('#btn').click((function () {
                $('#t1 > tbody  > tr').each((function (index, tr) {
                    var rowClass = $(this).attr('class');
                    null != rowClass && rowClass.includes('parentRow') && $(this).toggleClass('selected').closest('tr').next().toggle()
                }))
            }));

            $('#btnToggleFindings').click(function () {


                $('#t1 > tbody  > tr').each(function (index, tr) {

                    var rowClass = $(this).attr('class');
                    if (rowClass != null) {
                        if (rowClass.includes("parentRow")) {

                            $(this).toggleClass('selected').closest('tr').next().toggle();
                        }
                    }
                });
            });