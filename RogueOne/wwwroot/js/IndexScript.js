var indexScript = {
    getUserId: async function (username) {
        try
        {
            const response = await axios.get(`/Home/GetUserId?username=${username}`);

            return response.data;
        }
        catch (error)
        {
            console.log('getUserId', error);
        }
    },

    //getUserDetailsFromUserId: async function (userId) {
    //    try {
    //        const response = await axios.get(`/Home/GetUserDetailsFromUserId?userId=${userId}`);
    //        indexScript.displayUserDetails(response.data.items);
    //        $('#captionsBox').fadeIn();
    //    }
    //    catch (error) {
    //        console.log('getUserId', error);
    //    }
    //},

    displayUserDetails: function (data) {

        data.forEach((item) =>
        {
            console.log('new item', item.media.videoVersions.url)
            if (typeof user !== 'undefined') {
                $('#captionsRow').append(`
                <div class='col-3' >
                    <an href='${item.media.videoVersions.url}'>${item.media.videoVersions.url}</p>
                </div>`);
            } else {
                Swal.fire({
                    title: 'Error!',
                    text: 'User not found. Please check the username.',
                    icon: 'error',
                    confirmButtonText: 'OK'
                });
            }
           
        })
    },

    getPopulateUserInfo: async function () {
        let username = $('#username').val();
        let user = await indexScript.getUserId(username);

        if (typeof user !== 'undefined') { // Corrected check
            $('#userInfoBox').fadeIn();
            $('#userInfo').html(`
            <p><strong>Username:</strong> ${user.username}</p>
            <p><strong>Attempts:</strong> ${user.attempts}</p>
            <button class='btn btn-primary' onclick='indexScript.getReelsFromUserId(${user.userId})'>View more</button>
        `);
        } else {
            Swal.fire({
                title: 'Error!',
                text: 'User not found. Please check the username.',
                icon: 'error',
                confirmButtonText: 'OK'
            });
        }
    },

    getReelsFromUserId: async function (userId) {
        try {
            const response = await axios.get(`/Home/GetReelsFromUserId?userId=${userId}`);
            indexScript.displayUserDetails(response.data.items);
            $('#captionsBox').fadeIn();
            
        }
        catch (error) {
            console.log('getUserId', error);
        }
    },
}